namespace FirstWeb.Models
{
    public class Guest
    {
        public int GID { get; set; }
        public string? Name { get; set; }
    }


    public  class GuestList{

        public  IEnumerable<Guest> GL = new List<Guest>();


        public  IEnumerable<Guest> AllGuests() => GL.Where(x=>x.GID > 2);
        //public static List<Guest> AllGuests() {
        //    return GL;
        //}
        public  void AddGuest(Guest g)
        {
           GL= GL.Append(g);
        }

}
}
