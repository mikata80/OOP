using System;

namespace DelegatesEvents
{

    class runStudentExample
    {
        static void Main()
        {
            Student student = new Student("Peter", 22);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };
            student.Name = "Maria";
            student.Age = 19;

        }

    }

    class Student
    {
        public delegate void PropChage(object sender, PropertyChangedEventArgs eventArgs);

        private string name;
        private int age;
        private PropertyChangedEventArgs chgArgument;

        public event PropChage PropertyChanged;
        
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            { 
                return this.name; 
            }
            set
            {
                this.chgArgument = new PropertyChangedEventArgs("Name: ", this.name, value);
                this.name = value;
                this.FirePropertyChanged(this, chgArgument);
            }
        }

        public int Age
        {
            get
            { 
                return this.age; 
            }
            set
            {
                this.chgArgument = new PropertyChangedEventArgs("Age: ", this.age.ToString(), value.ToString());
                this.age = value;
                this.FirePropertyChanged(this, chgArgument);
            }
        }

        protected virtual void FirePropertyChanged(object sender, PropertyChangedEventArgs chgArgument)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, chgArgument);
            }
        }
       
    }

    class PropertyChangedEventArgs : EventArgs
    {
        private string propertyName;
        private string oldValue;
        private string newValue;

        public PropertyChangedEventArgs(string propertyName, string oldValue, string newValue)
        {
            this.propertyName = propertyName;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

        public string PropertyName
        {
            get { return this.propertyName; }
        }

        public string OldValue
        {
            get { return this.oldValue; }
        }

        public string NewValue
        {
            get { return this.newValue; }
        }
    }
}
