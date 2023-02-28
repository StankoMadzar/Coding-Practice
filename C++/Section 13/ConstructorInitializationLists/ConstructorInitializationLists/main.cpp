#include <iostream>
#include <string>

using namespace std;

class Player {
private:
	std::string name;
	int health;
	int xp;
public:
	void set_name(std::string name_val) {
		name = name_val;
	}

	Player() : name{ "None" }, health{ 0 }, xp{ 0 } {

	}

	Player(std::string name_val) : name{ name_val }, health{ 0 }, xp{ 0 } {

	}

	Player(std::string name_val, int health_val, int xp_val) 
		: name{ name_val }, health{ 0 }, xp{ xp_val } {

	}
};

int main() {

	Player empty;
	Player frank{ "Frank" };
	Player villain{ "Villain", 100, 55 };
	return 0;
}