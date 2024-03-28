function appendToResult(value) {
    document.getElementById('result').value += value;
  }
  
  function clearResult() {
    document.getElementById('result').value = '';
  }
  
  function calculateResult() {
    var result = document.getElementById('result').value;
    var calculatedResult = eval(result);
    localStorage.setItem('result', calculatedResult);
    window.location.href = 'result.html';
  }
  