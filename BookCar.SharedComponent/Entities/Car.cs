using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SoftMart.Core.Dao;

namespace BookCar.SharedComponent.Entities
{
    public class Car : BaseEntity
    {
        #region Primitive members

        public const string C_CarID = "CarID"; // 
        private int? _CarID;
        [PropertyEntity(C_CarID, true)]
        public int? CarID
        {
            get { return _CarID; }
            set { _CarID = value; NotifyPropertyChanged(C_CarID); }
        }

        public const string C_CategoryID = "CategoryID"; // 
        private int? _CategoryID;
        [PropertyEntity(C_CategoryID, false)]
        public int? CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; NotifyPropertyChanged(C_CategoryID); }
        }

        public const string C_Color = "Color"; // 
        private string _Color;
        [PropertyEntity(C_Color, false)]
        public string Color
        {
            get { return _Color; }
            set { _Color = value; NotifyPropertyChanged(C_Color); }
        }

        public const string C_Description = "Description"; // 
        private string _Description;
        [PropertyEntity(C_Description, false)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; NotifyPropertyChanged(C_Description); }
        }

        public const string C_PlateNumber = "PlateNumber"; // 
        private string _PlateNumber;
        [PropertyEntity(C_PlateNumber, false)]
        public string PlateNumber
        {
            get { return _PlateNumber; }
            set { _PlateNumber = value; NotifyPropertyChanged(C_PlateNumber); }
        }

        public const string C_Price = "Price"; // 
        private decimal? _Price;
        [PropertyEntity(C_Price, false)]
        public decimal? Price
        {
            get { return _Price; }
            set { _Price = value; NotifyPropertyChanged(C_Price); }
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


        public Car() : base("Car", "CarID", C_Deleted, C_Version) { }

        #endregion

        #region Extend members

        [PropertyEntity("MinPrice", false, false)]
        public decimal? MinPrice { get; set; }

        [PropertyEntity("MaxPrice", false, false)]
        public decimal? MaxPrice { get; set; }

        #endregion
    }


}
