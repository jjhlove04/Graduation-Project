let target = document.querySelector("#dynamic"); // document에서 dynamic이라는 요소를 가지고 있는 객체를 선택해서 target에 할당

//랜덤 스트링
function randomString() {
  let stringArr = [
    "Learn to HTML",
    "Learn to CSS",
    "Learn to Unity",
    "Learn to C#",
    "Learn to JavaScript",
    "Learn to After Effect",
  ];
  let selectString = stringArr[Math.floor(Math.random() * stringArr.length)];
  let selectStringArr = selectString.split("");

  return selectStringArr;
}
//타이핑 리셋
function resetTyping() {
  target.textContent = "";
  dynamic(randomString());
}

//한글자씩 텍스트 출력 함수
function dynamic(randomArr) {
  if (randomArr.length > 0) {
    target.textContent += randomArr.shift();
    setTimeout(function () {
      dynamic(randomArr);
    }, 80);
  } else {
    setTimeout(resetTyping, 3000);
  }
}
dynamic(randomString());
//커서 깜빡임
function blink() {
  target.classList.toggle("active");
}
setInterval(blink, 500);
