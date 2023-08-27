import java.util.Scanner;

public class Ex27 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        text = String.join("-", text.split(""));

        System.out.println(text);
        scanner.close();
    }
}
