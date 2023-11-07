class SeatManager {
public:
    // Declare a priority queue named availableSeats, which stores integers in descending order.
    std::priority_queue<int, std::vector<int>, std::greater<int>> availableSeats;

    // Constructor for initializing the SeatManager.
    SeatManager(int n) {
        // Initialize availableSeats with seat numbers from 1 to n.
        for (int i = 1; i <= n; i++) {
            availableSeats.push(i);
        }
    }
    // Reserve and return the smallest available seat.
    int reserve() 
    {
        int seat = availableSeats.top();// Get the smallest available seat (highest priority).
        availableSeats.pop();// Remove the reserved seat from the available seats.
        return seat;
    }
    // Unreserve a seat by adding it back to the available seats.
    void unreserve(int seatNumber) {
        // Add the unreserved seat number back to the available seats.
        availableSeats.push(seatNumber);
    }
};


/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager* obj = new SeatManager(n);
 * int param_1 = obj->reserve();
 * obj->unreserve(seatNumber);
 */