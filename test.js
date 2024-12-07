import http from 'k6/http';
import { check, sleep } from 'k6';

export const options = {
    vus: 200,
    duration: '30s', 
};

export default function () {
    const url = __ENV.TEST_URL || 'http://localhost:5000/api/test/task';


    const start = Date.now();
    const res = http.get(url);
    const end = Date.now();

    console.log(`Request Duration: ${end - start}ms`);

    check(res, {
        'status is 200': (r) => r.status === 200,
    });


    sleep(10 - ((end - start) / 1000));
}
