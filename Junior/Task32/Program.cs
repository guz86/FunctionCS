﻿namespace Task32
{
    class Program
    {
        static void Main()
        {
            /*
            Автосервис
                У вас есть автосервис, в который приезжают люди, чтобы починить свои автомобили.
                У вашего автосервиса есть баланс денег и склад деталей.Когда приезжает автомобиль, у него сразу ясна его
                поломка, и эта поломка отображается у вас в консоли вместе с ценой за починку(цена за
            починку складывается из цены детали + цена за работу).
            Поломка всегда чинится заменой детали, но количество деталей ограничено тем, что находится на вашем
                складе деталей.
                Если у вас нет нужной детали на складе, то вы можете отказать клиенту, и в этом случае вам придется
                выплатить штраф.
                Если вы замените не ту деталь, то вам придется возместить ущерб клиенту.
                За каждую удачную починку вы получаете выплату за ремонт, которая указана в чек - листе починки.
            */
            CarService carService = new CarService();
            carService.Start();
        }
    }
}