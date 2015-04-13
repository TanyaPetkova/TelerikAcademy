namespace _09_16_18_19.Students
{
    using System;

    class Group
    {
        private byte? groupNumber;
        private string departmentName;

        public Group(byte? groupNumber = 0, string departmentName = null)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public byte? GroupNumber 
        {
            get 
            {
                return this.groupNumber;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The group number cannot be a negative number.");
                }

                this.groupNumber = value;
            }
        }
        public string DepartmentName 
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                this.departmentName = value;
            }
       }
    }
}
