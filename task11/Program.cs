using task11.Abstract;
using task11.models;
// Интерфейсы
Car car = new Car();
car.Move(100);
Robot robot = new Robot();
robot.Move(200);
// Абстрактные классы
Appliance machine = new WashingMachine();
machine.TurnOff();
machine.TurnOn();
Appliance refr = new Refrigerator();
refr.TurnOn();
refr.TurnOff();
//Дополнительное задание
Animal dog = new Dog();
dog.Sleep();
((Dog)dog).Bark();
Animal cat = new Cat();
cat.Sleep();
((Cat)cat).Sound();