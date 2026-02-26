namespace Exercise1.Models;

public class ParkingTicketMachine
{
    private int minutesPrKr;
    private int[] cointsToInsert;
    private int amountInserted;
    private DateTime timeNow;

    public int[] CoinsToInsert => cointsToInsert;
    public DateTime TimeNow => timeNow;
    public DateTime PaidUntil => timeNow.AddMinutes(amountInserted * minutesPrKr);
    public int AmountInserted => amountInserted;

    public ParkingTicketMachine()
    {
        amountInserted = 0;
        timeNow = DateTime.Now;
        minutesPrKr = 3;
        cointsToInsert = [1, 2, 5, 10, 20];
    }

    public void insertCoin(int kr)
    {
        amountInserted += kr;
    }

}