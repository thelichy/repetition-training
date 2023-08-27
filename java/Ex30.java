import java.util.Scanner;

public class Ex30 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char[] text = scanner.nextLine().toLowerCase().toCharArray();
        char character = scanner.nextLine().toLowerCase().charAt(0);
        int occurrences = 0;

        for (char c : text) {
            if (c == character) {
                occurrences++;
            }
        }

        System.out.println(occurrences);
        scanner.close();
    }
}
