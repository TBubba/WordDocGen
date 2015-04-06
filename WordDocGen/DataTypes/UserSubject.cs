using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WordDocGen.DataTypes
{
    [DataContract, Serializable]
    internal class UserSubject
    {
        /// <summary>
        /// The name of the subject
        /// </summary>
        [DataMember(Name = "Name")]
        internal string Name;
        /// <summary>
        /// Path to subject folder
        /// </summary>
        [DataMember(Name = "FolerPath")]
        internal string FolderPath;

        // Constructor(s)
        internal UserSubject(string name, string folderPath)
        {
            Name = name;
            FolderPath = folderPath;
        }
        internal UserSubject(UserSubject subject)
        {
            Name = subject.Name;
            FolderPath = subject.FolderPath;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
