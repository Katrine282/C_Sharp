namespace opg2;

public class Calculation
{
    public int CalculationId { get; set; }
    public int tal1 { get; set; } 
    public int tal2 { get; set; } 
    public int result { get; set; }
    public string Operator { get; set; } = "";

    public Calculation(int tal1, int tal2, int result, string @operator)
    {
        this.tal1 = tal1;
        this.tal2 = tal2;
        this.result = result;
        Operator = @operator;
    }

    public Calculation()
    {
    }
}