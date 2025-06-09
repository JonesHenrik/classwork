//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
package Main;

import Vote.Vote;

import java.util.HashSet;
import java.util.Set;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Set<String> flavors = new HashSet<String>();
        Map<String, Integer> voteCount = new HashMap<String, Integer>();
        List<String> names = new ArrayList<String>();

        // Flavors Set
        flavors.add("strawberry");
        flavors.add("mintchocolatechip");
        flavors.add("vanilla");
        flavors.add("chocolate");
        flavors.add("cookiedough");

        // Family Members List
        names.add("Elizabeth");
        names.add("Charles");
        names.add("Anne");
        names.add("Edward");

        System.out.println("Let's vote on ice cream flavors. Here are your options:");
        printFlavors(flavors);

        for (String name : names) {
            boolean isValid = false;
            do {
                System.out.println("Which flavor do you want to vote for " + name);
                Scanner myObj = new Scanner(System.in);
                String vote = myObj.nextLine();
                vote.toLowerCase(Locale.ROOT).strip();

                // return bool if vote is in flavor list
                if (isFlavor(flavors, vote)) {
                    addPoints(voteCount, vote);
                    System.out.println("Thank you for vote " + name);
                    isValid = false;
                } else {
                    System.out.println("That is not a valid flavor. Please try again.");
                    isValid = true;
                }
            } while (isValid);
        }

        highestVote(voteCount);

    }

    // Print out the flavor options
    public static void printFlavors(Set<String> flavors) {
        for (String flavor : flavors) {
            System.out.println(flavor);
        }
    }

    // add point after a vote
    public static void addPoints(Map<String, Integer> voteCount, String input) {
        for (Map.Entry<String, Integer> vote : voteCount.entrySet()) {
            String key = vote.getKey();
            Integer value = vote.getValue();

            if (key.equals(input)) {
                value += 1;
            } else {
                voteCount.put(input, 1);
            }
        }
    }
    public static boolean isFlavor(Set<String> flavors, String input) {
        for (String flavor : flavors) {
            return flavor.contains(input);
        }
        return false;
    }

    public static void highestVote(Map<String, Integer> voteCount) {
        int highestValue = 0;
        String highestFlavor = "";
        for (Map.Entry<String, Integer> vote : voteCount.entrySet()) {
            if (vote.getValue() > highestValue) {
                highestValue = vote.getValue();
                highestFlavor = vote.getKey();
            }
        }

        System.out.println("The flavor(s) with the most votes are: \n" + highestFlavor);
    }
}