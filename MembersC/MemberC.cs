using System.Diagnostics;

namespace MembersC
{
    class Members
    {
        // member private field
        private string memberName;
        private string _jobTitle;
        private int _salary;

        // member public field
        public int age;

        public string JobTitle 
        { 
            get
            {
                return this._jobTitle;
            }
            set
            {
                this._jobTitle = value;
            } 
        }

        // public member method
        public void introducing(bool isFriend)
        {
            if(isFriend)
                this.sharingPrivateInfo();
            else
                System.Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", this.memberName, this.JobTitle, this.age);
        }

        private void sharingPrivateInfo()
        {
            System.Console.WriteLine("Hi, my salary is {0}", this._salary);
        }

        // member constructor 
        public Members()
        {
            this.age = 30;
            memberName = "Lucy";
            this._salary = 60000;
            this._jobTitle = "Developer";
            System.Console.WriteLine("Object created...");
        }

        // member finalizer / destructor
        ~Members()
        {
            // clean up statements
            System.Console.WriteLine("Deconstruction of Member object...");
            Debug.Write("Destruction of Member Object....");
        }

    }
}