//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrenciesRatesParser.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoinsRate
    {
        public long Id { get; set; }
        public string Acronim { get; set; }
        public string Site { get; set; }
        public double Sell { get; set; }
        public double Buy { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<bool> IsUp { get; set; }
    }
}
