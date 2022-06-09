using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddfdf
{
    static class BuildingInfo
    {
        public static void ShowInfo(int object_number)
        {
            switch (object_number)
            {
                case 1: MessageBox.Show("Бонус к добыче дерева.\n1 уровень: +10%\n2 уровень: +20%\n3 уровень: +30%","Лесопилка"); break;
                case 2: MessageBox.Show("Бонус к добыче камня.\n1 уровень: +8%\n2 уровень: +16%\n3 уровень: +24%", "Каменоломня"); break;
                case 3: MessageBox.Show("Бонус к добыче провизии.\n1 уровень: +15%\n2 уровень: +25%\n3 уровень: +35%", "Ферма"); break;
                case 5: MessageBox.Show("Появляется возможность торговать.\n1 уровень: доступ к продаже/покупке ресурсов\n2 уровень: доступ" +
                    " к продаже/покупке снаряжения\n3 уровень: доступ к найму рабочей силы", "Рынок"); break;
                case 6: MessageBox.Show("Доступ к взятию кредитов.\n1 уровень: максимальный кредит 2к золота на 14 дней\n2 уровень: " +
                    "максимальный кредит 5к золота на 14 дней\n3 уровень: максимальный кредит 10к золота на 14 дней", "Банк"); break;
                case 7: MessageBox.Show("Открывает сбор налогов.\n1 уровень: 5 золота с каждого жителя в 3 дня\n2 уровень: 7 золота с " +
                    "каждого жителя в 3 дня\n3 уровень: 9 золота с каждого жителя в 3 дня", "Мэрия"); break;
                case 8: MessageBox.Show("Открывает новые лоты на рынке.\n1 уровень: редкие\n2 уровень: древние\n3 уровень: внеземные", "Порт"); break;
                case 4: MessageBox.Show("Открывает возможность производить снаряжение.\n1 уровень: обычное\n2 уровень: необычное\n3 уровень: редкое", "Кузница"); break;
                case 9: MessageBox.Show("Позволяет создавать воинов.\n1 уровень: 5% от общего населения\n2 уровень: 10% от общего населения\n3 " +
                    "уровень: 15% от общего населения", "Казармы"); break;
            }
        }
        public static List<Control> setDisable(List<Control> button)
        {
            for (int i = 0, j = button.Count() - 1; i < DataBank.all_price.Count(); i += 2, j--)
            {
                if (DataBank.wood < DataBank.all_price[i] || DataBank.stone < DataBank.all_price[i + 1])
                    button[j].Enabled = false;
            }
            return button;
        }
    }
}
