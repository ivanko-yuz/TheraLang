export class LiqpayResponse {
    constructor(
        public amount: number,
        public status: string,
        public donationId: string,
    ) { }
}
