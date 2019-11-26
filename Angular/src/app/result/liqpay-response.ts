export class LiqpayResponse {
    constructor(
        public projectId: number,
        public amount: number,
        public status: string,
        public donationId: string,
    ) { }
}