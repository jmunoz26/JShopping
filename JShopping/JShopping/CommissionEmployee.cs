using System;

namespace JShopping;

public class CommissionEmployee : Employee
{
  public float CommissionPercentaje { get; set; }
  public decimal Sales { get; set; }
  public override decimal GetValueToPay()
  {
    return Sales * (decimal)CommissionPercentaje;
  }

  public override string ToString()
  {
    return $"{base.ToString()}" +
        $"\n\tCommission percentaje: {$"{CommissionPercentaje:P2}",18}" +
        $"\n\tSales................: {$"{Sales:C2}",18}" +
        $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18}";
  }
}
