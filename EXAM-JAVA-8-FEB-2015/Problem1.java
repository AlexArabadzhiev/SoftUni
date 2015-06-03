import java.util.Scanner;

public class Problem1 {
    static Scanner in = new Scanner(System.in);
    public static void main(String[] args) {
        int Mood = Integer.parseInt(in.nextLine());
        String InputStr = in.nextLine().toLowerCase();
        String[] StrArray = InputStr.split("[^A-Za-z]+");
        for (int i = 0; i < StrArray.length; i++) {
            if (StrArray[i].equals("cram")){
                Mood+=2;
                continue;
            }
            if (StrArray[i].equals("lembas")){
                Mood+=3;
                continue;
            }
            if (StrArray[i].equals("apple")){
                Mood+=1;
                continue;
            }if (StrArray[i].equals("melon")){
                Mood+=1;
                continue;
            }
            if (StrArray[i].equals("honeycake")){
                Mood+=5;
                continue;
            }
            if (StrArray[i].equals("mushrooms")){
                Mood-=10;
                continue;
            }
            else {
                Mood-=1;
            }
         }
        if(Mood<-5){
            System.out.println(Mood);
            System.out.println("Angry");
            return;
        }
        if(Mood>=-5&& Mood<0){
            System.out.println(Mood);
            System.out.println("Sad");
            return;
        }
        if(Mood>=0&& Mood<15){
            System.out.println(Mood);
            System.out.println("Happy");
            return;
        }
        if (Mood>=15){
            System.out.println(Mood);
            System.out.println("Special JavaScript mood");
            return;
        }
    }
}
