
const data = [
    {
        "id": 1,
        "name": "joao",
        "cpf": "14832124676",
        "cep": null,
        "state": null,
        "city": null,
        "street": "rua amaxonas",
        "number": 0,
        "email": "kennedy@gmail.com",
        "celphoneNumber": "47993207702",
        "password": "12345678",
        "totalPoints": 300
    },
    {
        "id": 3,
        "name": "kennedy",
        "cpf": "17832124676",
        "cep": null,
        "state": null,
        "city": null,
        "street": null,
        "number": 0,
        "email": "kennedymessias@gmail.com",
        "celphoneNumber": "47996207702",
        "password": "12345678",
        "totalPoints": 700
    },
    {
        "id": 4,
        "name": "gabriel",
        "cpf": "14832124686",
        "cep": "89037010",
        "state": "solteiro",
        "city": "blumenau",
        "street": "rua meu saco",
        "number": 0,
        "email": "gabrielromario13@gmail.com",
        "celphoneNumber": "47993207702",
        "password": "12345678",
        "totalPoints": 750
    },
    {
        "id": 5,
        "name": "gabriel",
        "cpf": "08566738977",
        "cep": "89037010",
        "state": "solteiro",
        "city": "blumenau",
        "street": "rua meu saco",
        "number": 0,
        "email": "gabrielromario13@gmail.com",
        "celphoneNumber": "47993207702",
        "password": "12345678",
        "totalPoints": 500
    },
    {
        "id": 6,
        "name": "gabriel",
        "cpf": "08566738977",
        "cep": "89037010",
        "state": "solteiro",
        "city": "blumenau",
        "street": "rua meu saco",
        "number": 9,
        "email": "gabrielromario13@gmail.com",
        "celphoneNumber": "47993207702",
        "password": "12345678",
        "totalPoints": 900
    },
    {
        "id": 7,
        "name": "marcelo",
        "cpf": "14832124676",
        "cep": "89037010",
        "state": "SC",
        "city": "Blumenau",
        "street": "Júlio Baumgarten",
        "number": 333,
        "email": "gabriel.rcosta57@gmail.com",
        "celphoneNumber": "47991201020",
        "password": "6542463",
        "totalPoints": 1000
    },
    {
        "id": 7,
        "name": "marcelo",
        "cpf": "14832124676",
        "cep": "89037010",
        "state": "SC",
        "city": "Blumenau",
        "street": "Júlio Baumgarten",
        "number": 333,
        "email": "gabriel.rcosta57@gmail.com",
        "celphoneNumber": "47991201020",
        "password": "6542463",
        "totalPoints": 673
    }
]


const getData = () => {
    var points = []
    points = data.map((user) => user.totalPoints)
    return points;
}

// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';

// Area Chart Example
var ctx = document.getElementById("myAreaChart");
var myLineChart = new Chart(ctx, {
  type: 'line',
  data: {
    labels: ["Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"],
    datasets: [{
      label: "Sessions",
      lineTension: 0.3,
      backgroundColor: "rgba(2,117,216,0.2)",
      borderColor: "rgba(2,117,216,1)",
      pointRadius: 5,
      pointBackgroundColor: "rgba(2,117,216,1)",
      pointBorderColor: "rgba(255,255,255,0.8)",
      pointHoverRadius: 5,
      pointHoverBackgroundColor: "rgba(2,117,216,1)",
      pointHitRadius: 50,
      pointBorderWidth: 2,
      data: getData(),
    }],
  },
  options: {
    scales: {
      xAxes: [{
        time: {
          unit: 'date'
        },
        gridLines: {
          display: false
        },
        ticks: {
          maxTicksLimit: 7
        }
      }],
      yAxes: [{
        ticks: {
          min: 0,
          max: 1000,
          maxTicksLimit: 5
        },
        gridLines: {
          color: "rgba(0, 0, 0, .125)",
        }
      }],
    },
    legend: {
      display: false
    }
  }
});
