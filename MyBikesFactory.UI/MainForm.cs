using MyBikesFactory.Business;
using MyBikesFactory.Business.Enums;
using MyBikesFactory.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class MainForm : Form
    {
        private List<Bike> listofBikes = BikeXMLData.Load();
        private Dictionary<int, int> dictionaryOfIndexes = new Dictionary<int, int>();
        private bool thereAreUnsavedChanges = false;
        private Form previousForm;

        public MainForm(Form referenceForm)
        {
            InitializeComponent();
            RefreshDisplayList();
            previousForm = referenceForm;
        }

        public MainForm()
        {
            InitializeComponent();
            RefreshDisplayList();

        }
        #region Support Methods
        private int GetIndexFromDictionary()
        {
            int listBoxIndex = lstBikes.SelectedIndex;
            if (listBoxIndex < 0)
            {
                return -1;
            }
            return dictionaryOfIndexes[listBoxIndex];
        }
        private Bike? FindBikeById(int id)
        {
            Bike? bikeFound = null;
            foreach (var bike in listofBikes)
            {
                if (bike.Id == id)
                {
                    bikeFound = bike;
                    break;
                }
            }

            return bikeFound;
            //LINQ Alternative:
            //return bikeFound.FirstOrDefault(s => s.Id == id)
        }

        private void RefreshDisplayList()
        {
            lstBikes.Items.Clear();
            dictionaryOfIndexes.Clear();    
            int listCounter = 0;
            foreach (var Bike in listofBikes)
            {
                bool include = false;

                if (rbDisplayAll.Checked)
                {
                    include = true;
                }
                else if (rbDisplayMountain.Checked && Bike is MountainBike)
                {
                    include = true;
                }
                else if (rbDisplayRoad.Checked && Bike is RoadBike)
                {
                    include = true;
                }

                if (include)
                {
                    dictionaryOfIndexes.Add(lstBikes.Items.Count, listCounter);
                    lstBikes.Items.Add(Bike.ToString());
                }
                listCounter++;
            }
        }

        private bool AllFieldsAreOk()
        {
            if (cbBikeType.Text == "")
            {
                MessageBox.Show("Please select a bike type");
                return false;
            }
            else if (txtId.Text == "" || !Validator.ValidateId(txtId.Text))
            {
                MessageBox.Show("Id is required and should contain only numeric characters only");
                return false;
            }
            else if (txtManufacturingYear.Text == "")
            {
                MessageBox.Show("Please inform a amnufacturing year");
                return false;
            }
            else if (!Validator.ValidateManufacturingYear(txtManufacturingYear.Text))
            {
                MessageBox.Show("Manufacturing year must be 4 numbers");
                return false;
            }
            return true;
        }


        #endregion

        private void BikeToAdd_GotInvalidNotification(string message)
        {
            //throw new NotImplementedException();
            MessageBox.Show(message);
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
            {
                return;
            }
            
            else if (!Validator.ValidateUniqueId(txtId.Text, listofBikes))
            {
                MessageBox.Show("This id is already used");
                return;
            }
            

            Bike bikeToAdd;
            if (cbBikeType.Text == "Mountain")
            {
                ESuspension suspensionType = (ESuspension)cbSuspensionType.SelectedIndex;
                bikeToAdd = new MountainBike(suspensionType);
            }
            else
            {
                ETireType tireType = (ETireType)cbTireType.SelectedIndex;
                bikeToAdd = new RoadBike(tireType);
            }

            bikeToAdd.Id = Convert.ToInt32(txtId.Text);
            bikeToAdd.Model = txtModel.Text;
            bikeToAdd.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);

            bikeToAdd.Color = (EColor)cbColor.SelectedIndex;


            bikeToAdd.GotInvalidNotification += BikeToAdd_GotInvalidNotification;

            if (!bikeToAdd.IsValid())
            {
                return;
            }

            listofBikes.Add(bikeToAdd);

            cbBikeType.SelectedIndex = 0;
            txtId.Text = "";
            txtModel.Text = "";
            txtManufacturingYear.Text = "";
            cbColor.Text = "";
            cbSuspensionType.Text = "";
            cbTireType.Text = "";

            RefreshDisplayList();

            thereAreUnsavedChanges = true;
            MessageBox.Show("The bike has been added");
        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
            {
                return;
            }
            else if (txtId.Text != txtOriginalId.Text)
            {
                if (!Validator.ValidateUniqueId(txtId.Text, listofBikes))
                {
                    MessageBox.Show("This id is already used.");
                    return;
                }
            }
            int origianlId = Convert.ToInt32(txtOriginalId.Text);
            var bikeToUpdate = FindBikeById(origianlId); 

            if (bikeToUpdate is MountainBike && cbBikeType.Text == "Road" ||
               bikeToUpdate is RoadBike && cbBikeType.Text == "Mountain")
            {
                int listIndex = GetIndexFromDictionary();
                listofBikes.RemoveAt(listIndex);
                if (cbBikeType.Text == "Mounntain")
                    bikeToUpdate = new MountainBike();
                else
                    bikeToUpdate = new RoadBike();
                listofBikes.Insert(listIndex, bikeToUpdate);

            }

            if (cbBikeType.Text == "Mountain")
            {
                (bikeToUpdate as MountainBike)!.SuspensionType = (ESuspension)cbSuspensionType.SelectedIndex;
            }
            else
            {
                (bikeToUpdate as RoadBike)!.TireType = (ETireType)cbTireType.SelectedIndex;
            }
            bikeToUpdate.Id = Convert.ToInt32(txtId.Text);
            bikeToUpdate.Model = txtModel.Text;
            bikeToUpdate.ManufacturingYear = Convert.ToInt32(txtManufacturingYear.Text);

            bikeToUpdate.Color = (EColor)cbColor.SelectedIndex;
            //bikeToUpdate.Color = (Ecolor)Enum.Parse(typeof(Ecolor), cbColor.Text); //best way

            RefreshDisplayList();

            thereAreUnsavedChanges = true;
            MessageBox.Show("The bike has been update");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            BikeXMLData.Save(listofBikes);

            thereAreUnsavedChanges = false;
            MessageBox.Show("The list of bike has been saved");
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBikeType.Text == "Mountain")
            {
                cbSuspensionType.Enabled = true;
                cbTireType.Enabled = false;
            }
            else
            {
                cbSuspensionType.Enabled = false;
                cbTireType.Enabled = true;
            }
            cbSuspensionType.SelectedIndex = -1;
            cbTireType.SelectedIndex = -1;
        }

        private void rbDisplayMountain_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstBikes.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void rbDisplayAll_CheckedChanged_1(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstBikes.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void rbDisplayRoad_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstBikes.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void lstBikes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int listIndeXmlReadMode = GetIndexFromDictionary();
            if (lstBikes.SelectedIndex < 0)
            {
                return;
            }

            var bike = listofBikes[lstBikes.SelectedIndex];
            if (bike is MountainBike)
            {
                cbBikeType.SelectedIndex = 0;
                var bikeAsMountain = (MountainBike)bike;
                cbSuspensionType.SelectedIndex = (int)bikeAsMountain.SuspensionType;
            }
            else
            {
                cbBikeType.SelectedIndex = 1;
                var bikeAsRoad = (RoadBike)bike;
                cbTireType.SelectedIndex = (int)bikeAsRoad.TireType;
            }
            
            txtId.Text = bike.Id.ToString();
            txtOriginalId.Text = txtId.Text;
            txtModel.Text = bike.Model;
            txtManufacturingYear.Text = bike.ManufacturingYear.ToString();
            cbColor.SelectedIndex = (int)bike.Color;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            int index = lstBikes.SelectedIndex;
            if (lstBikes.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a bike to remove");
                return;
            }

            var result = MessageBox.Show("Do you really want to remove?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            listofBikes.RemoveAt(index);
            lstBikes.Items.RemoveAt(index);
            thereAreUnsavedChanges = true;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text == "" || !Validator.ValidateId(txtId.Text))
            {
                MessageBox.Show("Id is required and should be numeric");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            var bikeFound = FindBikeById(id);

            if (bikeFound == null)
            {
                MessageBox.Show("Bike not found");
                return;
            }

            string message = bikeFound.ToString().Replace(",", Environment.NewLine);
            MessageBox.Show(message);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message;
            MessageBoxButtons buttons;
            MessageBoxIcon icon;

            if (thereAreUnsavedChanges)
            {
                message = "There are unsaved changes, would you like to save and exit?";
                buttons = MessageBoxButtons.YesNoCancel;
                icon = MessageBoxIcon.Warning;
            }
            else
            {
                message = "Do you really want to exit?";
                buttons = MessageBoxButtons.YesNoCancel;
                icon = MessageBoxIcon.Information;
            }

            var result = MessageBox.Show(message,
                                         "Confirm",
                                         buttons,
                                         icon);

            if (result != DialogResult.Yes && thereAreUnsavedChanges)
            {
                BikeBinaryData.Save(listofBikes);
            }
            else if (result == DialogResult.No && !thereAreUnsavedChanges)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

            if (!e.Cancel)
            {
                //e.Cancel = true;
                previousForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBikes.Items.Clear();
            dictionaryOfIndexes.Clear();
        }
    }
}

//good bonus ?did u save before exiting the aplication? make a clear button to clear the document