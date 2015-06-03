import java.util.Scanner;

public class Problem3 {
    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        int n = Integer.parseInt(in.nextLine());
        int Counter = 0;
        String[] ArrayStr1 = new String[n];
        String[] OutputArr = new String[n];
        boolean Maches = true;
        for (int i = 0; i < n; i++) {
            String CurrString = in.nextLine();
            String now = CurrString.replaceAll("\\s", "");
            ArrayStr1[i] = now;
        }
        String[] ArrayStr2 = new String[n];
        for (int i = 0; i < ArrayStr2.length; i++) {
            String CurrString = in.nextLine();
            String now = CurrString.replaceAll("\\s", "");
            String reverse = new StringBuffer(now).reverse().toString();
            ArrayStr2[i] = reverse;
            String combine = ArrayStr1[i] + ArrayStr2[i];
            OutputArr[i] = combine;
        }
        for (int i = 0; i < ArrayStr1.length -1; i++) {
            int Lenght = OutputArr[i].length();
            if (OutputArr[i+1].length() != Lenght){
                Maches = false;
            }
        }
        for (int i = 0; i < OutputArr.length; i++) {
            Counter += OutputArr[i].length();

        }
        if (Maches == true){
            for (int i = 0; i < OutputArr.length; i++) {
                String str = OutputArr[i];
                String[] StringForPrint = str.split("");
                System.out.print("[");
                System.out.print(StringForPrint[0]);
                for (int j = 1; j < StringForPrint.length-1; j++) {
                    System.out.print(", " + StringForPrint[j]);
                }
                System.out.print(", " + StringForPrint[StringForPrint.length - 1]);
                System.out.print("]");
                System.out.println();

            }

        }
        else {
            System.out.println("The total number of cells is: " + Counter);
        }

    }
}
