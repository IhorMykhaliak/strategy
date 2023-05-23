using System.Text;
using Strategy;
using static System.Console;

// для виводу укр. літер
OutputEncoding = Encoding.UTF8;

Character king = new King();
king.Display();
king.Fight();
king.SetWeapon(new AxeBehavior());
king.Fight();

WriteLine();

Character trool = new Trool();
trool.Display();
trool.Fight();
trool.SetWeapon(new BowAndArrowBehavior());
trool.Fight();

ReadLine();