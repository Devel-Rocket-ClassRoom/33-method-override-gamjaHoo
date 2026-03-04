using System;

////1-1

//Parent p = new Parent();
//p.Work();
//Child c = new Child();
//c.Work();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}

//class Child : Parent
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로게이머");
//    }
//}



////1-2
//Animal animal = new Cat();
//animal.Eat();
//class Animal
//{
//    public virtual void Eat()
//    {
//        Console.WriteLine("Animal Eat");
//    }
//}

//class Cat : Animal
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Cat Eat");
//    }
//}



////2
//Parent parent = new Child();
//Child child = new Child();

//child.Say();
//child.Run();
//child.Walk();
//Console.WriteLine();
//parent.Say();
//parent.Run();
//parent.Walk();
//class Parent
//{
//    public void Say()
//    {
//        Console.WriteLine("부모_안녕하세요.");
//    }
//    public void Run()
//    {
//        Console.WriteLine("부모_달리다.");
//    }

//    public virtual void Walk()
//    {
//        Console.WriteLine("부모_걷다");
//    }
//}

//class Child : Parent
//{
//    public new void Say()
//    {
//        Console.WriteLine("자식_안녕하세요.");
//    }
//    public new void Run()
//    {
//        Console.WriteLine("자식_달리다.");
//    }

//    public override void Walk()
//    {
//        Console.WriteLine("자식_걷다");
//    }
//}



////3-1
//Calculator c = new Calculator();
//c.Add(1, 2);
//c.Add(1.5, 2.5);
//c.Add(1, 2, 3);
//class Calculator
//{
//    public void Add(int a, int b)
//    {
//        Console.WriteLine(a + b);
//    }
//    public void Add(double a, double b)
//    {
//        Console.WriteLine(a + b); 
//    }

//    public void Add(int a, int b, int c)
//    {
//        Console.WriteLine(a + b + c);
//    }
//}



////3-2
//Animal animal = new Animal();
//Animal dog = new Dog();
//Animal cat = new Cat();

//animal.Speak();
//dog.Speak();
//cat.Speak();
//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("동물이 소리를 낸다");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("멍멍!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("야옹!");
//    }
//}



////4-1
//Child c = new Child();
//c.Greet();
//class Parent
//{
//    public virtual void Greet()
//    {
//        Console.WriteLine("안녕하세요.");
//    }
//}

//class Child : Parent
//{
//    public override void Greet()
//    {
//        base.Greet();
//        Console.WriteLine("반갑습니다.");
//    }
//}



////4-2
//Parent parent = new Parent();
//Child child = new Child();
//GrandChild grandChild = new GrandChild();

//parent.Work();
//child.Work();
//grandChild.Work();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}

//class Child : Parent
//{
//    public override void Work()
//    {
//        base.Work();
//    }
//}

//class GrandChild : Child
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로게이머");
//    }
//}



////5
//Parent parent = new Parent();
//Child child = new Child();
//GrandChild grandChild = new GrandChild();

//parent.Work();
//child.Work();
//grandChild.Work();
//grandChild.Play();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}

//class Child : Parent
//{
//    public sealed override void Work()
//    {
//        base.Work();
//    }
//}

//class GrandChild : Child
//{
//    public void Play()
//    {
//        Console.WriteLine("프로게이머");
//    }
//}



////6-1
//Person p = new Person();
//Console.WriteLine(p);
//Console.WriteLine(p.ToString());
//class Person
//{
//    public string Name { get; set; }

//}



////6-2
//Person p = new Person("박용준");
////Console.WriteLine(p);
//Console.WriteLine(p.ToString());
//class Person
//{
//    public string Name { get; set; }

//    public Person(string name)
//    {
//        Name = name;
//    }

//    public override string ToString()
//    {
//        return $"[Person 클래스: {Name}]";
//    }
//}



////6-3
//Character c1 = new Character("용사", 10, 100);
//Character c2 = new Character("마법사", 8, 70);

//Console.WriteLine(c1);
//Console.WriteLine(c2);

//class Character
//{
//    private string Name;
//    private int Level;
//    private int Health;

//    public Character(string name, int level, int health)
//    {
//        Name = name;
//        Level = level;
//        Health = health;
//    }

//    public override string ToString()
//    {
//        return $"[{Name}] Lv.{Level} HP:{Health}";
//    }
//}



////7-1
//Character warrior = new Warrior("전사", 50);
//Character mage = new Mage("마법사", 30);
//Character archer = new Archer("궁수", 40);

//Console.WriteLine(warrior);
//Console.WriteLine(mage);
//Console.WriteLine(archer);
//Console.WriteLine();
//warrior.Attack();
//mage.Attack();
//archer.Attack();
//class Character
//{
//    public string Name;
//    public int AttackPower;

//    public Character(string name, int attackPower)
//    {
//        Name = name;
//        AttackPower = attackPower;
//    }

//    public virtual void Attack()
//    {

//    }

//    public override string ToString()
//    {
//        return $"[{Name}] 공격력: {AttackPower}";
//    }
//}

//class Warrior : Character
//{
//    public Warrior(string name, int attackPower) : base(name, attackPower) { }
//    public override void Attack()
//    {
//        Console.WriteLine($"{Name}(이)가 칼로 베어냅니다!  데미지: {AttackPower}");
//    }
//}
//class Mage : Character
//{
//    public Mage(string name, int attackPower) : base(name, attackPower) { }

//    public override void Attack()
//    {
//        Console.WriteLine($"{Name}(이)가 파이어볼을 시전합니다!  데미지: {AttackPower}");
//    }
//}
//class Archer : Character
//{
//    public Archer(string name, int attackPower) : base(name, attackPower) { }

//    public override void Attack()
//    {
//        Console.WriteLine($"{Name}(이)가 화살을 쏩니다!  데미지: {AttackPower}");
//    }
//}



//7-2
Character[] party = new Character[]
{
    new Warrior("전사", 50),
    new Mage("마법사", 30),
    new Archer("궁수", 40)
};

Console.WriteLine("=== 파티 공격 ===");
foreach (Character member in party)
{
    member.Attack();
}
class Character
{
    public string Name;
    public int AttackPower;

    public Character(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }

    public virtual void Attack()
    {

    }

    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}

class Warrior : Character
{
    public Warrior(string name, int attackPower) : base(name, attackPower) { }
    public override void Attack()
    {
        Console.WriteLine($"{Name}(이)가 칼로 베어냅니다!  데미지: {AttackPower}");
    }
}
class Mage : Character
{
    public Mage(string name, int attackPower) : base(name, attackPower) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}(이)가 파이어볼을 시전합니다!  데미지: {AttackPower}");
    }
}
class Archer : Character
{
    public Archer(string name, int attackPower) : base(name, attackPower) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}(이)가 화살을 쏩니다!  데미지: {AttackPower}");
    }
}