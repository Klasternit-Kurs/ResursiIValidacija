using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ResursiIValidacija
{
	class ValidatorZaGodine : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			if (int.TryParse(value.ToString(), out int broj))
			{
				if (broj >= 18 && broj <= 100)
					return ValidationResult.ValidResult;
				else
					return new ValidationResult(false, "Broj nije izmedju 18 i 100");
			} else
				return new ValidationResult(false, "Ovo nije broj :/");
		}
	}
}
