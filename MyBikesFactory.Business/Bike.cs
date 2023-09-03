using MyBikesFactory.Business.Interfaces;
using MyBikesFactory.Business.Delegates;
using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBikesFactory.Business
{


    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    public abstract class Bike : IValidatable
    {
        //id, model, manufacturing Year and color.
        private int _id;
        private string _model;
        private int _manufacturingYear;
        private EColor _color;
        private string _invalidmessage;

        [field: NonSerialized]
        public event Notify GotInvalidNotification;
 
        public int Id { get => _id; set => _id = value; }
        public string Model { get => _model; set => _model = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }
        public EColor Color { get => _color; set => _color = value; }

        public string InvalidMessage { get => _invalidmessage; set => _invalidmessage = value; }


        public Bike()
        {
            _id = 0;
            _model = "";
            _manufacturingYear = 0;
            _color = EColor.Undefined;
            _invalidmessage = "";
        }

        public Bike(int initialId) : this()
        {
            _id = initialId;
        }

        public override string ToString()
        {
            return $"Id: {_id}, Model: {_model}, Manufacturing Year: {_manufacturingYear}, Color: {_color}";
        }

        public virtual bool IsValid()
        {
            if (_id == 0)
            {
                GotInvalidNotification("Please enter an id greater than zero");
                return false;
            }
            else if (_model == "")
            {
                GotInvalidNotification("Please inform a model");
                return false;
            }
            else if (!Validator.ValidateModel(_model))
            {
                GotInvalidNotification("Model should contain 5 charaters (numbers or letters)");
                return false;
            }
            else if (_manufacturingYear == 0)
            {
                GotInvalidNotification("Please inform a manufacturing year");
                return false;
            }
            else if (_color == EColor.Undefined)
            {
                GotInvalidNotification("Please select a color");
                return false;
            }
            return true;
        }

        protected void GotInvalidChildNotification(string message)
        {
            GotInvalidNotification(message);
        }
    }
}
