import java.util.Scanner;

public class Ex20 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder result = new StringBuilder();
        int factorial = 1;

        int number = scanner.nextInt();
        for (int i = number; i >= 1; i--) {
            factorial *= i;
            result.append("*").append(i);
        }

        result.append(" => ").append(factorial);
        System.out.println(result.substring(1));

        scanner.close();
    }
}
