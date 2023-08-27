import java.util.Scanner;

public class Ex28 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int vowels = 0;
        char[] text = scanner.nextLine().toLowerCase().toCharArray();

        for (char c : text) {
            switch (c) {
                case 'a', 'e', 'i', 'o', 'u' -> {
                    vowels++;
                }
            }
        }

        System.out.println(vowels);
        scanner.close();
    }
}
