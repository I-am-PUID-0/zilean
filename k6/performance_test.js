import http from 'k6/http';
import { check, sleep } from 'k6';
import { Rate } from 'k6/metrics';

export let errorRate = new Rate('errors');

export let options = {
  stages: [
    { duration: '1m', target: 10 },
    { duration: '3m', target: 10 },
    { duration: '1m', target: 20 },
    { duration: '3m', target: 20 },
    { duration: '1m', target: 0 },
  ],
  thresholds: {
    'http_req_duration': ['p(95)<500'],
    'http_req_failed': ['rate<0.01'],
    'errors': ['rate<0.01'],
  },
};

export default function () {
  let url = 'http://localhost:8181/dmm/search';
  let payload = JSON.stringify({ queryText: 'iron man 3' });
  let params = {
    headers: {
      'Content-Type': 'application/json',
    },
  };

  let res = http.post(url, payload, params);

  let checkRes = check(res, {
    'is status 200': (r) => r.status === 200,
    'response body is not empty': (r) => r.body.length > 0,
  });

  errorRate.add(!checkRes);

  if (!checkRes) {
    console.log(`Error: ${res.status} - ${res.body}`);
  }

  sleep(1);
}
