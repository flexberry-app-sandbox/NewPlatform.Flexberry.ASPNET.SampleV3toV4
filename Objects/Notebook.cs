﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.SampleV3toV4
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Notebook.
    /// </summary>
    // *** Start programmer edit section *** (Notebook CustomAttributes)

    // *** End programmer edit section *** (Notebook CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("NotebookE", new string[] {
            "Model as \'Model\'",
            "SerialNumber as \'Serial number\'",
            "Person as \'Person\'",
            "Person.Name as \'Name\'"})]
    [AssociatedDetailViewAttribute("NotebookE", "Hardware", "HardwareE", true, "", "Hardware", true, new string[] {
            ""})]
    [View("NotebookL", new string[] {
            "Model as \'Model\'",
            "SerialNumber as \'Serial number\'",
            "Person.Name as \'Name\'"})]
    public class Notebook : ICSSoft.STORMNET.DataObject
    {
        
        private string fModel;
        
        private string fSerialNumber;
        
        private NewPlatform.SampleV3toV4.Person fPerson;
        
        private NewPlatform.SampleV3toV4.DetailArrayOfHardware fHardware;
        
        // *** Start programmer edit section *** (Notebook CustomMembers)

        // *** End programmer edit section *** (Notebook CustomMembers)

        
        /// <summary>
        /// Model.
        /// </summary>
        // *** Start programmer edit section *** (Notebook.Model CustomAttributes)

        // *** End programmer edit section *** (Notebook.Model CustomAttributes)
        [StrLen(255)]
        public virtual string Model
        {
            get
            {
                // *** Start programmer edit section *** (Notebook.Model Get start)

                // *** End programmer edit section *** (Notebook.Model Get start)
                string result = this.fModel;
                // *** Start programmer edit section *** (Notebook.Model Get end)

                // *** End programmer edit section *** (Notebook.Model Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Notebook.Model Set start)

                // *** End programmer edit section *** (Notebook.Model Set start)
                this.fModel = value;
                // *** Start programmer edit section *** (Notebook.Model Set end)

                // *** End programmer edit section *** (Notebook.Model Set end)
            }
        }
        
        /// <summary>
        /// SerialNumber.
        /// </summary>
        // *** Start programmer edit section *** (Notebook.SerialNumber CustomAttributes)

        // *** End programmer edit section *** (Notebook.SerialNumber CustomAttributes)
        [StrLen(255)]
        public virtual string SerialNumber
        {
            get
            {
                // *** Start programmer edit section *** (Notebook.SerialNumber Get start)

                // *** End programmer edit section *** (Notebook.SerialNumber Get start)
                string result = this.fSerialNumber;
                // *** Start programmer edit section *** (Notebook.SerialNumber Get end)

                // *** End programmer edit section *** (Notebook.SerialNumber Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Notebook.SerialNumber Set start)

                // *** End programmer edit section *** (Notebook.SerialNumber Set start)
                this.fSerialNumber = value;
                // *** Start programmer edit section *** (Notebook.SerialNumber Set end)

                // *** End programmer edit section *** (Notebook.SerialNumber Set end)
            }
        }
        
        /// <summary>
        /// Notebook.
        /// </summary>
        // *** Start programmer edit section *** (Notebook.Person CustomAttributes)

        // *** End programmer edit section *** (Notebook.Person CustomAttributes)
        [PropertyStorage(new string[] {
                "Person"})]
        public virtual NewPlatform.SampleV3toV4.Person Person
        {
            get
            {
                // *** Start programmer edit section *** (Notebook.Person Get start)

                // *** End programmer edit section *** (Notebook.Person Get start)
                NewPlatform.SampleV3toV4.Person result = this.fPerson;
                // *** Start programmer edit section *** (Notebook.Person Get end)

                // *** End programmer edit section *** (Notebook.Person Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Notebook.Person Set start)

                // *** End programmer edit section *** (Notebook.Person Set start)
                this.fPerson = value;
                // *** Start programmer edit section *** (Notebook.Person Set end)

                // *** End programmer edit section *** (Notebook.Person Set end)
            }
        }
        
        /// <summary>
        /// Notebook.
        /// </summary>
        // *** Start programmer edit section *** (Notebook.Hardware CustomAttributes)

        // *** End programmer edit section *** (Notebook.Hardware CustomAttributes)
        public virtual NewPlatform.SampleV3toV4.DetailArrayOfHardware Hardware
        {
            get
            {
                // *** Start programmer edit section *** (Notebook.Hardware Get start)

                // *** End programmer edit section *** (Notebook.Hardware Get start)
                if ((this.fHardware == null))
                {
                    this.fHardware = new NewPlatform.SampleV3toV4.DetailArrayOfHardware(this);
                }
                NewPlatform.SampleV3toV4.DetailArrayOfHardware result = this.fHardware;
                // *** Start programmer edit section *** (Notebook.Hardware Get end)

                // *** End programmer edit section *** (Notebook.Hardware Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Notebook.Hardware Set start)

                // *** End programmer edit section *** (Notebook.Hardware Set start)
                this.fHardware = value;
                // *** Start programmer edit section *** (Notebook.Hardware Set end)

                // *** End programmer edit section *** (Notebook.Hardware Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "NotebookE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View NotebookE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("NotebookE", typeof(NewPlatform.SampleV3toV4.Notebook));
                }
            }
            
            /// <summary>
            /// "NotebookL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View NotebookL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("NotebookL", typeof(NewPlatform.SampleV3toV4.Notebook));
                }
            }
        }
    }
}