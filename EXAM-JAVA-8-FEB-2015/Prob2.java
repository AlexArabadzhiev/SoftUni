import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Prob2 {
    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        double Output = 0;
        String[] FirstImput = in.nextLine().split("[\\s]+");
        for (int i = 0; i < FirstImput.length; i++) {
            String CurrentElement = FirstImput[i];
            String[] Letters = CurrentElement.split("[0-9]+");
            Pattern p = Pattern.compile("[0-9]+");
            Matcher m = p.matcher(CurrentElement);
            int n = 0;
            while (m.find()) {
                n = Integer.parseInt(m.group());
            }
            char a = CurrentElement.charAt(0);
            char b = CurrentElement.charAt(CurrentElement.length() - 1);
            double CurrSum = n;
            if (a > 96) {
                CurrSum = CurrSum * (a - 96);
            } else if (a < 91) {
                CurrSum = CurrSum / (a - 64);
            }
            if (b > 96) {
                CurrSum += (b - 96);
            } else if (b < 91) {
                CurrSum -= (b - 64);
            }
            Output += CurrSum;

        }
        System.out.printf("%.2f", Output);
    }
}
