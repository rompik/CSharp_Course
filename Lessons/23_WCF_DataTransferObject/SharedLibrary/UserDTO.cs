﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class UserDTO : INotifyPropertyChanged
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }

        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
