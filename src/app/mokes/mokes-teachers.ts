import { Teacher } from '../model/teacher';
import { Class } from '../model/class';

export const CLASSES: Class[] = [
    // tslint:disable-next-line:max-line-length
    { id: 11, name: 'bachata', fri: false, individualCost: 12.12, mon: false, mounthCost: 123.21, sat: false, schedule: '12.00 to 13.00', sun: false, thu: false, totalCost: 200.00, tue: false, typeClass: 1, wen: false }
];
export const TEACHERS: Teacher[] = [
    { id: 11, name: 'Mr. Nice', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 12, name: 'Narco', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 13, name: 'Bombasto', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 14, name: 'Celeritas', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 15, name: 'Magneta', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 16, name: 'RubberMan', phone: 52323423, email: 'strato.berto@gmail.com' , classes: CLASSES},
    { id: 17, name: 'Dynama', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 18, name: 'Dr IQ', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 19, name: 'Magma', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES },
    { id: 20, name: 'Tornado', phone: 52323423, email: 'strato.berto@gmail.com', classes: CLASSES }
];


