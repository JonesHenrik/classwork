package Vote;

import java.util.*;

public class Vote {
     private Set<String> flavors;
     private Map<String, Integer> voteCount;
     private List<String> names;

    public Vote() {
        this.flavors = new HashSet<String>();
        this.voteCount = new HashMap<String, Integer>();
        this.names = new ArrayList<String>();
    }

    public Set<String> getFlavors() {
        return flavors;
    }

    public void setFlavors(Set<String> flavors) {
        this.flavors = flavors;
    }

    public Map<String, Integer> getVoteCount() {
        return voteCount;
    }

    public void setVoteCount(Map<String, Integer> voteCount) {
        this.voteCount = voteCount;
    }

    public List<String> getNames() {
        return names;
    }

    public void getNames(List<String> names) {
        this.names = names;
    }

    public void printFlavors() {
        for (String flavor : flavors) {
            System.out.println(flavor);
        }
    }
}
