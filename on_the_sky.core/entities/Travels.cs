namespace on_the_sky
{
    public class Travels
    {
        public int passengerid { get; set; }
        public string passengername { get; set; }
        public int flightid { get; set; }
        public int countryid { get; set; }
        public int amounttickets { get; set; }
        public Travels( int passid,string passname, int flid,int coid, int amtid )
        {
            passengername = passname;
            passengerid = passid;
            flightid = flid;
            countryid = coid;
            amounttickets = amtid;
        }
    }
}
