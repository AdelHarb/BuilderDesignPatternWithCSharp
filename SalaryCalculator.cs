namespace Builder;

public class SalaryCalculator
{
    public SalaryCalculator(
        int taxRate = 0,
        decimal bonusRate = 0,
        decimal educationRate = 0,
        decimal transportation = 0,
        bool sendPaysLipToEmployee = false,
        bool postResultToGL = false)
    {
        TaxRate = taxRate;
        BonusRate = bonusRate;
        EducationRate = educationRate;
        Transportation = transportation;
        SendPaysLipToEmployee = sendPaysLipToEmployee;
        PostResultToGL = postResultToGL;
    }
    public int TaxRate { get; }
    public decimal BonusRate { get; }
    public decimal EducationRate { get; }
    public decimal Transportation { get; }
    public bool SendPaysLipToEmployee { get; }
    public bool PostResultToGL { get; }
}