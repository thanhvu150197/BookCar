using SoftMart.Core.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.SharedComponent.Entities
{

    public class ServiceOrder : BaseEntity
    {
        #region Primitive members

        public const string C_OrderID = "OrderID"; // 
        private int? _OrderID;
        [PropertyEntity(C_OrderID, true)]
        public int? OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; NotifyPropertyChanged(C_OrderID); }
        }

        public const string C_CarID = "CarID"; // 
        private int? _CarID;
        [PropertyEntity(C_CarID, false)]
        public int? CarID
        {
            get { return _CarID; }
            set { _CarID = value; NotifyPropertyChanged(C_CarID); }
        }

        public const string C_TimeCategory = "TimeCategory"; // 
        private int? _TimeCategory;
        [PropertyEntity(C_TimeCategory, false)]
        public int? TimeCategory
        {
            get { return _TimeCategory; }
            set { _TimeCategory = value; NotifyPropertyChanged(C_TimeCategory); }
        }

        public const string C_OrderDuration = "OrderDuration"; // 
        private int? _OrderDuration;
        [PropertyEntity(C_OrderDuration, false)]
        public int? OrderDuration
        {
            get { return _OrderDuration; }
            set { _OrderDuration = value; NotifyPropertyChanged(C_OrderDuration); }
        }

        public const string C_PlanStartDTG = "PlanStartDTG"; // 
        private DateTime? _PlanStartDTG;
        [PropertyEntity(C_PlanStartDTG, false)]
        public DateTime? PlanStartDTG
        {
            get { return _PlanStartDTG; }
            set { _PlanStartDTG = value; NotifyPropertyChanged(C_PlanStartDTG); }
        }

        public const string C_PlanEndDTG = "PlanEndDTG"; // 
        private DateTime? _PlanEndDTG;
        [PropertyEntity(C_PlanEndDTG, false)]
        public DateTime? PlanEndDTG
        {
            get { return _PlanEndDTG; }
            set { _PlanEndDTG = value; NotifyPropertyChanged(C_PlanEndDTG); }
        }

        public const string C_ActualStartDTG = "ActualStartDTG"; // 
        private DateTime? _ActualStartDTG;
        [PropertyEntity(C_ActualStartDTG, false)]
        public DateTime? ActualStartDTG
        {
            get { return _ActualStartDTG; }
            set { _ActualStartDTG = value; NotifyPropertyChanged(C_ActualStartDTG); }
        }

        public const string C_ActualEndDTG = "ActualEndDTG"; // 
        private DateTime? _ActualEndDTG;
        [PropertyEntity(C_ActualEndDTG, false)]
        public DateTime? ActualEndDTG
        {
            get { return _ActualEndDTG; }
            set { _ActualEndDTG = value; NotifyPropertyChanged(C_ActualEndDTG); }
        }

        public const string C_CustomerName = "CustomerName"; // 
        private string _CustomerName;
        [PropertyEntity(C_CustomerName, false)]
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; NotifyPropertyChanged(C_CustomerName); }
        }

        public const string C_Description = "Description"; // 
        private string _Description;
        [PropertyEntity(C_Description, false)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; NotifyPropertyChanged(C_Description); }
        }

        public const string C_Status = "Status"; // 
        private int? _Status;
        [PropertyEntity(C_Status, false)]
        public int? Status
        {
            get { return _Status; }
            set { _Status = value; NotifyPropertyChanged(C_Status); }
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


        public ServiceOrder() : base("ServiceOrder", "OrderID", C_Deleted, C_Version) { }

        #endregion

        #region Extend members

        #endregion
    }

}
