using System;
namespace sing.song
{
    public class Singer {


        string _name;
        string _surname;
        int _age;

        public  Name(string name)

        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return (_name);
            }

            set
            {
                if (value.Length > 3 && value.Length < 100)
                {
                    Name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return (_surname);

            }
            set
            {
                if (value.Length > 3 && value.Length < 100)
                {
                    Surname = value;
                }

            }
        }

        public int Age
        {
            get
            {
                return (_age);

            }
            set
            {

                if (value.Length > 0 && value.Length < 170)
                {
                    Age = value;
                }
            }
        }

    }

}
