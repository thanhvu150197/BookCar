using SoftMart.Core.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.SharedComponent.Entities
{
    public class TimeCategory : BaseEntity
    {
        #region Primitive members

        public const string C_TimeCategoryID = "TimeCategoryID"; // 
        private int? _TimeCategoryID;
        [PropertyEntity(C_TimeCategoryID, true)]
        public int? TimeCategoryID
        {
            get { return _TimeCategoryID; }
            set { _TimeCategoryID = value; NotifyPropertyChanged(C_TimeCategoryID); }
        }

        public const string C_Name = "Name"; // 
        private string _Name;
        [PropertyEntity(C_Name, false)]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; NotifyPropertyChanged(C_Name); }
        }

        public const string C_Description = "Description"; // 
        private string _Description;
        [PropertyEntity(C_Description, false)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; NotifyPropertyChanged(C_Description); }
        }

        public const string C_Deleted = "Deleted"; // 
        private int? _Deleted;
        [PropertyEntity(C_Deleted, false)]
        public int? Deleted
        {
            get { return _Deleted; }
            set { _Deleted = value; NotifyPropertyChanged(C_Deleted); }
        }

        public const string C_Version = "Version"; // 
        private int? _Version;
        [PropertyEntity(C_Version, false)]
        public int? Version
        {
            get { return _Version; }
            set { _Version = value; NotifyPropertyChanged(C_Version); }
        }

        public const string C_CreatedBy = "CreatedBy"; // 
        private string _CreatedBy;
        [PropertyEntity(C_CreatedBy, false)]
        public string CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; NotifyPropertyChanged(C_CreatedBy); }
        }

        public const string C_CreatedDTG = "CreatedDTG"; // 
        private DateTime? _CreatedDTG;
        [PropertyEntity(C_CreatedDTG, false)]
        public DateTime? CreatedDTG
        {
            get { return _CreatedDTG; }
            set { _CreatedDTG = value; NotifyPropertyChanged(C_CreatedDTG); }
        }

        public const string C_UpdatedBy = "UpdatedBy"; // 
        private string _UpdatedBy;
        [PropertyEntity(C_UpdatedBy, false)]
        public string UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; NotifyPropertyChanged(C_UpdatedBy); }
        }

        public const string C_UpdatedDTG = "UpdatedDTG"; // 
        private DateTime? _UpdatedDTG;
        [PropertyEntity(C_UpdatedDTG, false)]
        public DateTime? UpdatedDTG
        {
            get { return _UpdatedDTG; }
            set { _UpdatedDTG = value; NotifyPropertyChanged(C_UpdatedDTG); }
        }


        public TimeCategory() : base("TimeCategory", "CarCategoryID", C_Deleted, C_Version) { }

        #endregion

        #region Extend members

        #endregion
    }

}
