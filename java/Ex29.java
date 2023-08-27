import java.util.Scanner;

public class Ex29 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        boolean found = false;
        char[] text = scanner.nextLine().toLowerCase().toCharArray();
        char vowel = scanner.nextLine().toLowerCase().charAt(0);

        for (char c : text) {
            if (c == vowel) {
                found = true;
                break;
            }
        }

        System.out.println(found);
        scanner.close();
    }
}
