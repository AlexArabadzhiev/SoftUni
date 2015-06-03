import java.nio.file.attribute.UserDefinedFileAttributeView;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.UnknownFormatConversionException;

public class Problem4 {
    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
       TreeMap<String,TreeMap<String,Integer>> Output = new TreeMap<>();

        while(true){
            if (in.nextLine().equals("end")){
                break;
            }
            String[] Inputrow = in.nextLine().split("[IP= ]+");
            String User = Inputrow[5];
            String Ip = Inputrow[1];
            int Count =0;
            if (!Output.containsKey(User)){
                Output.put(User, new TreeMap<>());
                Output.get(User).put(Ip, Count);

            }
            else{
                if(Output.get(User).containsKey(Ip)){
                    Count = Output.get(User).get(Ip);
                    Output.get(User).put(Ip, Count++);
                }
                else{
                    Output.get(User).put(Ip,Count);
                }
            }

        }





    }
}
