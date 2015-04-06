using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WordDocGen.DataTypes
{
    [DataContract]
    internal class UserSettings
    {
        /// <summary>
        /// List of subjects the user is attending
        /// </summary>
        [DataMember(Name = "Subjects")]
        internal List<UserSubject> Subjects;

        /// <summary>
        /// The users full name
        /// </summary>
        [DataMember(Name = "FullName")]
        internal string FullName;
        /// <summary>
        /// What grade the full user is in
        /// </summary>
        [DataMember(Name = "Grade")]
        internal string Grade;

        // Constrcutor(s)
        internal UserSettings()
        {
            Subjects = new List<UserSubject>();
            FullName = "";
            Grade = "";
        }

        /// <summary>
        /// Returns the default user settings
        /// </summary>
        /// <returns>Default user settings</returns>
        internal static UserSettings Default()
        {
            return new UserSettings()
                {
                    FullName = "Lasse Berghagen",
                    Grade = "SUN12"
                };
        }
    }
}
