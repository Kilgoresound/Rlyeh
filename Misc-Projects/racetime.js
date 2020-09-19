let raceNumber = Math.floor(Math.random() * 1000);

const earlyReg = false;

const age = 18;

if (age > 18 && earlyReg === true) {
  raceNumber += 1000;
};

if( raceNumber > 1000) {
  console.log(`Race start time for ${raceNumber} is 9:30 AM. Congrats, you're old and punctual. I bet you got a lot of tail in college.`)
} else if(age > 18 && earlyReg === false) {
  console.log(`Race start time for adults who can not be bothered to be early, such as number ${raceNumber}, is 11:00 AM.`)
} else if(age < 18) {
  console.log(`Youngbloods run at 12:30 PM. This means you, ${raceNumber}.`)
}else {
  console.log(`Uh oh. We got a live one. See the registration desk, ${raceNumber}.`)
}