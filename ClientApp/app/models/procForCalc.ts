export class ProcForCalc {
    id: number;
    productNameFull: string;
    numProcs: number;
    tpse: number;
    tpseCore: number;

    constructor(id: number, productNameFull: string, numProcs: number, tpse: number, tpseCore: number )
    {
        this.id = id;
        this.productNameFull = productNameFull;
        this.numProcs = numProcs;
        this.tpse = tpse;
        this.tpseCore = tpseCore;
    }

    get totalTpse() {
        return this.numProcs * this.tpse;
    }
}