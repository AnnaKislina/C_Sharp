Console.Clear();


/* string str = "Она несла в руках отвратительные, тревожные желтые цветы. "
            +"Черт их знает, как их зовут, но они первые почему-то появляются в Москве."
            +" И эти цветы очень отчетливо выделялись на черном ее весеннем пальто. Она"
            +" несла желтые цветы! Нехороший цвет. Она повернула с Тверской в переулок и"
            +" тут обернулась. Ну, Тверскую вы знаете?";

string[] separate = {", ",". ","! ","?","-"," "}; 
string[] stArr1 = str.Split(separate, StringSplitOptions.RemoveEmptyEntries); //принять группу разделителей

for (int i = 0; i < stArr1.Length; i++)
{
    System.Console.Write(stArr1[i]);
} */

//Стринговый массив в интовый и наоборот

string strnum = "1,2,3,4,5";
int[] Num = new int[strnum.Length];
string[] charArr = strnum.Split(",");
for (int i = 0; i < strnum.Length; i++)
{
    Num[i] = Convert.ToInt32(charArr[i]);
    System.Console.WriteLine(Num[i]);
}

System.Console.WriteLine();
