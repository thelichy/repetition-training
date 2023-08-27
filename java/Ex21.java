import java.util.Scanner;

public class Ex21 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();
        int power = scanner.nextInt();
        int raised = 1;

        if (power > 0) {
            for (int i = 0; i < power; i++) {
                raised *= number;
            }
        } else if (power < 0) {
            throw new IllegalArgumentException("Power below 0 is not permitted");
        }

        System.out.printf("Power of %d raised to %d => %d", number, power, raised);
        scanner.close();
    }
}
