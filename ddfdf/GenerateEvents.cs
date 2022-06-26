using System;
using System.Windows.Forms;


namespace ddfdf
{
    class GenerateEvents
    {
        readonly string caption = "Событие!";
        readonly Random rand = new Random();
        public void Generate()
        {
            int value = rand.Next(1,10);
            int v;
            switch (value)
            {
                case 1:
                    {
                        v = rand.Next(1,5);
                        DialogResult result = MessageBox.Show("Кто-то из вашего поселения" +
                            $" зажег костер. Это увидели путники и скитальцы.\n + {v} чел. к населению.\nПринять их?",
                            caption, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DataBank.human += v;
                        }
                    }break;
                case 2:
                    {
                        v = rand.Next(1, 10);
                        if (DataBank.isMedCenterBuild == false)
                        {
                            MessageBox.Show($"Несколько жителей погибло из-за падения ели во время добычи дерева\n" +
                                $"- {v} чел. Совет: постройте больницу для сокращения летальных исходов.", caption, 
                                MessageBoxButtons.OK);
                            DataBank.human -= v;
                        }
                        else
                        {
                            //add variant for medcenter
                        }
                    }break;
                case 3:
                    {
                        MessageBox.Show("Будущей зимой ожидаются сильные заморозки. -20% к добыче провизии, +10% к " +
                            "использованию древесины для отапливания." +
                            "следующей зимой.", caption, MessageBoxButtons.OK);
                        DataBank.foodBonus = 0.8d;
                        DataBank.woodInWinter += 0.1d;
                        DataBank.alreadyFoodEvent = true;
                    }break;
                case 4:
                    {
                        MessageBox.Show("В следующем году весна ожидается аномально жаркой. +20% к добыче провизии " +
                            "следующей зимой.", caption, MessageBoxButtons.OK);
                        DataBank.foodBonus = 1.2d;
                        DataBank.alreadyFoodEvent = true;
                    }
                    break;
                case 5:
                    {
                        MessageBox.Show("Через ваше поселение пройдет торговый караван.\nНовые предметы на рынке в течение " +
                            "следующих 3-х дней", caption, MessageBoxButtons.OK);
                        DataBank.CaravanDays = 3;
                        DataBank.isCaravanHere = true;
                    }
                    break;
                case 6:
                    {
                        v = rand.Next(3, 10);
                        if (DataBank.isMedCenterBuild == false)
                        {
                            MessageBox.Show($"Несколько жителей погибло из-за вспышки инфекции на ферме\n" +
                                $"- {v} чел. Совет: постройте больницу для сокращения летальных исходов.", caption,
                                MessageBoxButtons.OK);
                            DataBank.human -= v;
                        }
                        else
                        {
                            //add variant for medcenter
                        }
                    }
                    break;
                case 7:
                    {
                        MessageBox.Show("Щелчок Таноса... -50% населения.","Секретное событие!", MessageBoxButtons.OK);
                        DataBank.human /= 2;
                    }
                    break;
                case 8:
                    {
                        MessageBox.Show("Из-за весенних дождей ваши посевы пришли в негодность.\n-60% к добыче провизии" +
                            " до следующего сезона.", 
                            caption, MessageBoxButtons.OK);
                        DataBank.foodBonus = 0.4;
                        DataBank.alreadyFoodEvent = true;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
