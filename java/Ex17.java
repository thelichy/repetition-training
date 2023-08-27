import java.util.Scanner;

public class Ex17 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder result = new StringBuilder();
        int sum = 0;
        int num = scanner.nextInt();

        for (int i = 1; i <= num; i++) {
            sum += i;
            result.append("+").append(i);
        }

        result.append(" => ").append(sum);
        System.out.println(result.substring(1));

        scanner.close();
    }
}
