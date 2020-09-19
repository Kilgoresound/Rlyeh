userName = 'Squanchy';

userName ? console.log(`What up ${userName}!`) : console.log(`What up, my Glip-Glop!`);

const userQuestion = 'Is mankind facing Squanchmageddon?';

console.log(`${userName} asks: ${userQuestion}`);

const randomNumber = Math.floor(Math.random() * 8);

eightBall = '';

switch (randomNumber) {
  case 0:
  eightBall = `It is of absolute certainty.`;
  break;
  case 1:
  eightBall = `There is no alternative.`;
  break;
  case 2:
  eightBall = `The die is cast, and fate will decide, not you or I.`;
  break;
  case 3:
  eightBall = `Here lies a paradox, and there is no clear path.`;
  break;
  case 4:
  eightBall = `An impossibility, I'm afraid.`;
  break;
  case 5:
  eightBall = `${userName}, child. Now is no time to rely on chance. The answer is no.`;
  break;
  case 6:
  eightBall = `Following this path will result in catastrophe. The answer is no.`;
  break;
  case 7:
  eightBall = `The thread has been pulled, ${userName} and these events are already set in motion. An inevitibility. You will bear witness, and consequences will be upon you and those you hold dear.`;
  break;
 default:
  console.log(`Behold, and bear witness. R'hilor is taking a nap. Even the Lord of Light must rest from time to time.`) ;

}

console.log(`Your question has been heard. Behold your answer: ${eightBall}`);