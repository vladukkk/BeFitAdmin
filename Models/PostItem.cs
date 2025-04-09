using System;

namespace BeFitAdmin
{
    public class PostItem
    {
        private string _title;
        private string _description;
        private string _imageUrl;
        private string _createdDate;

        public PostItem(string title, string description, string imageUrl, string createdDate)
        {
            Title = title;
            Description = description;
            _imageUrl = imageUrl;
            _createdDate = createdDate;
        }

        private void validate(ref string validateValue, string value, string strName,int sizeFrom, int sizeTo)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException($"{strName} can't be null");
            else if (value.Length < sizeFrom)
                throw new ArgumentException($"{strName} must be at least {sizeFrom} characters long.");
            else if (value.Length > sizeTo)
                throw new ArgumentException($"{strName} cannot exceed {sizeTo} characters.");
            else
                validateValue = value;
        }

        public string Title 
        { 
            get { return _title; } 
            set { validate(ref _title, value, "Title",1,10); } 
        }
        public string Description { 
            get { return _description; } 
            set { validate(ref _description,value,"Description",10,1500);} 
        }

        public string ImageUrl {get { return _imageUrl; }set { _imageUrl = value; } }
        public string CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
    }
}
