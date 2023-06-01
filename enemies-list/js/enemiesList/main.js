// Put your code here
console.log("My Enemies List!")
console.log("----------------")

const enemies = {
    members: [
        {
            name: "Joshua Flowers",
            offenses: "Being a jerk to me in elementary school, not being nice to me in elementary school",
            isReallyHated: true
        },
        {
            name: "Darth Vader",
            offenses:"Cut off Luke's hand, murdered all those kids, unkind management practices",
            isReallyHated: false
        },
        {
            name: "Betty Rudelady",
            offenses:  "Phone calls in the theater, the bus, and in line at the grocery store. Poor conversationalist",
            isReallyHated: true  
        },
        {
            name: "Leon Peck",
            offenses: "Keeps giving me a hotplate",
            isReallyHated: false,
        }
    ]
};

enemies.members.forEach(members => {
    if (members.isReallyHated) {
        console.log(`${members.name} really, really dislike`);
    } else {
        console.log(`${members.name}, just normally dislike`);
    }
});

