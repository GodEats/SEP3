package via.sep3.food.Model;


import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Ingredient {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    int Id;
    String Name;
    double Calories;

    public Ingredient() {
    }

    public Ingredient(int id,String name, double calories) {
        Id=id;
        Name = name;
        Calories = calories;
    }

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public double getCalories() {
        return Calories;
    }

    public void setCalories(double calories) {
        Calories = calories;
    }

    @Override
    public String toString() {
        return "Ingredient{" +
                "Id=" + Id +
                ", Name='" + Name + '\'' +
                ", Calories=" + Calories +
                '}';
    }
}
