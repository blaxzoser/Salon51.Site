import { Class } from './class';

export class Teacher {

    constructor(
        public id: number,
        public name: string,
        public phone: number,
        public email: string,
        public classes: Class[]
    ) { }

}

