> Автосервис

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

* **class CarService** - _countPenalty, _countForceMajeur, _sumForceMajeur, _clients, Money, методы Start - обслуживание,
  ClientQueue - формирование очереди, Service - ремонт, ShowStorage - инфо о складе, PayClient - оплата, PenaltyPart - штраф,
  ForceMajeur - форсмажоры

* **class Client** - Money, Id - что нужно заменить

* **class Storage** - Parts, методы AddStoragePart - создаем склад, CreatePart - создание деталей для склада, ShowInfoPart() - инфо о складе,
  IdPart() - id деталей, RepairPart - удаление детали со склада, CostPart - цена детали, WorkPricePart - оплата за установку

* **class Part** - Id, Cost, Count, WorkPrice


