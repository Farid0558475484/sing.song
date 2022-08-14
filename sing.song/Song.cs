using System;
namespace sing.song
{
    public class Song
    {
        String _name;
        String _genre;
        String _singer;


        
        public Name(string name)
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

                if(value.Length > 0 && value.Length<100)
                {
                    Name = value;
                }
            }
        }

        public Genre(string genre)
        {
            Genre = genre;

        }
        public string Genre
        {
            get
            {

                return (_genre);

            }
            set
            {
                if (Pop(value) && Rock(value) && Jazz(value) && Techno(value))
                {
                    Pop = value;
                    Rock = value;
                    Jazz = value;
                    Techno = value;
                        


                }
            }
        }
    }
}
