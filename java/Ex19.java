import java.util.Scanner;

public class Ex19 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder result = new StringBuilder();
        int sum = 0;
        int limit = scanner.nextInt();
        limit = limit % 2 == 0 ? limit - 1 : limit;

        for (int i = 1; i <= limit; i += 2) {
            sum += i;
            result.append("+").append(i);
        }

        result.append(" => ").append(sum);
        System.out.println(result.substring(1));

        scanner.close();
    }
}
